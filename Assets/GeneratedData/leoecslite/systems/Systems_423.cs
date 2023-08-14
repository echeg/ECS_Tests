using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System423 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component497> _p1;
EcsPool<Component176> _p2;
EcsPool<Component125> _p3;
EcsPool<Component130> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component497>().Inc<Component176>().Inc<Component125>().End();
   _p1 = _world.GetPool<Component497>();
   _p2 = _world.GetPool<Component176>();
   _p3 = _world.GetPool<Component125>();
   _pl0 = _world.GetPool<Component130>();
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
