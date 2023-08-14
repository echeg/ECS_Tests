using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System439 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component163> _p1;
EcsPool<Component31> _p2;
EcsPool<Component490> _p3;
EcsPool<Component307> _p4;
EcsPool<Component429> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().Inc<Component31>().Inc<Component490>().Inc<Component307>().End();
   _p1 = _world.GetPool<Component163>();
   _p2 = _world.GetPool<Component31>();
   _p3 = _world.GetPool<Component490>();
   _p4 = _world.GetPool<Component307>();
   _pl0 = _world.GetPool<Component429>();
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
