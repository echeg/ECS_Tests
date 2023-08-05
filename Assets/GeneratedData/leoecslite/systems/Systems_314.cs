using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System314 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component385> _p1;
EcsPool<Component311> _p2;
EcsPool<Component405> _p3;
EcsPool<Component272> _p4;
EcsPool<Component352> _pl0;
EcsPool<Component379> _pl1;
EcsPool<Component453> _pl2;
EcsPool<Component245> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component385>().Inc<Component311>().Inc<Component405>().Inc<Component272>().End();
   _p1 = _world.GetPool<Component385>();
   _p2 = _world.GetPool<Component311>();
   _p3 = _world.GetPool<Component405>();
   _p4 = _world.GetPool<Component272>();
   _pl0 = _world.GetPool<Component352>();
   _pl1 = _world.GetPool<Component379>();
   _pl2 = _world.GetPool<Component453>();
   _pl3 = _world.GetPool<Component245>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
