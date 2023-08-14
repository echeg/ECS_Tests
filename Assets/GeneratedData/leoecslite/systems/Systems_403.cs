using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System403 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component54> _p2;
EcsPool<Component327> _p3;
EcsPool<Component5> _p4;
EcsPool<Component18> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component54>().Inc<Component327>().Inc<Component5>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component54>();
   _p3 = _world.GetPool<Component327>();
   _p4 = _world.GetPool<Component5>();
   _pl0 = _world.GetPool<Component18>();
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
