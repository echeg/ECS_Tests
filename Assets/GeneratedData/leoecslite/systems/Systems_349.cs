using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System349 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component71> _p1;
EcsPool<Component368> _p2;
EcsPool<Component495> _p3;
EcsPool<Component379> _pl0;
EcsPool<Component426> _pl1;
EcsPool<Component238> _pl2;
EcsPool<Component473> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component71>().Inc<Component368>().Inc<Component495>().End();
   _p1 = _world.GetPool<Component71>();
   _p2 = _world.GetPool<Component368>();
   _p3 = _world.GetPool<Component495>();
   _pl0 = _world.GetPool<Component379>();
   _pl1 = _world.GetPool<Component426>();
   _pl2 = _world.GetPool<Component238>();
   _pl3 = _world.GetPool<Component473>();
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
