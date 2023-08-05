using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System32 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component214> _p2;
EcsPool<Component24> _p3;
EcsPool<Component340> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component214>().Inc<Component24>().Inc<Component340>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component214>();
   _p3 = _world.GetPool<Component24>();
   _p4 = _world.GetPool<Component340>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
