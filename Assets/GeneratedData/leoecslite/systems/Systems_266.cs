using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System266 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component214> _p1;
EcsPool<Component92> _p2;
EcsPool<Component164> _p3;
EcsPool<Component177> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component214>().Inc<Component92>().Inc<Component164>().End();
   _p1 = _world.GetPool<Component214>();
   _p2 = _world.GetPool<Component92>();
   _p3 = _world.GetPool<Component164>();
   _pl0 = _world.GetPool<Component177>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
