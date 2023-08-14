using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System496 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component285> _p1;
EcsPool<Component37> _p2;
EcsPool<Component79> _p3;
EcsPool<Component96> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component285>().Inc<Component37>().Inc<Component79>().End();
   _p1 = _world.GetPool<Component285>();
   _p2 = _world.GetPool<Component37>();
   _p3 = _world.GetPool<Component79>();
   _pl0 = _world.GetPool<Component96>();
 }
 public void Run (IEcsSystems systems) {
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
  }
 }
}

}
