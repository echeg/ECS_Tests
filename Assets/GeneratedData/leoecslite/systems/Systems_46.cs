using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System46 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component206> _p1;
EcsPool<Component255> _p2;
EcsPool<Component189> _p3;
EcsPool<Component379> _p4;
EcsPool<Component238> _pl0;
EcsPool<Component458> _pl1;
EcsPool<Component167> _pl2;
EcsPool<Component428> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component255>().Inc<Component189>().Inc<Component379>().End();
   _p1 = _world.GetPool<Component206>();
   _p2 = _world.GetPool<Component255>();
   _p3 = _world.GetPool<Component189>();
   _p4 = _world.GetPool<Component379>();
   _pl0 = _world.GetPool<Component238>();
   _pl1 = _world.GetPool<Component458>();
   _pl2 = _world.GetPool<Component167>();
   _pl3 = _world.GetPool<Component428>();
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
