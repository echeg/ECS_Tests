using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System65 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component331> _p1;
EcsPool<Component289> _p2;
EcsPool<Component240> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component331>().Inc<Component289>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component331>();
   _p2 = _world.GetPool<Component289>();
   _p3 = _world.GetPool<Component240>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
