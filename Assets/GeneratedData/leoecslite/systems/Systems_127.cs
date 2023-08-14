using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System127 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component300> _p1;
EcsPool<Component314> _p2;
EcsPool<Component19> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component300>().Inc<Component314>().Inc<Component19>().End();
   _p1 = _world.GetPool<Component300>();
   _p2 = _world.GetPool<Component314>();
   _p3 = _world.GetPool<Component19>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
