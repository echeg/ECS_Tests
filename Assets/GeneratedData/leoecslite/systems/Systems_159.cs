using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System159 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component490> _p2;
EcsPool<Component141> _p3;
EcsPool<Component306> _p4;
EcsPool<Component160> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component490>().Inc<Component141>().Inc<Component306>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component490>();
   _p3 = _world.GetPool<Component141>();
   _p4 = _world.GetPool<Component306>();
   _pl0 = _world.GetPool<Component160>();
 }
 public void Run (EcsSystems systems) {
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
